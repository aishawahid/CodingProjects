#include <stdio.h>
#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <cmath>
#include <opencv2/core/mat.hpp>
using namespace cv;
using namespace std;


String imagePath;
Mat sourceImage, greyDisplay, blurDisplay, cannyDisplay, linesDisplay, shortFilterDisplay, horizontalDisplay, horizonDisplay;
int lowerThreshold = 0;

//Binary threshold variable
int thresholdVal = 0;
int minimumLength = 0;
int maximumGap = 0;
vector<Vec4i> lines;

int polynomial = 0;
int lineLength = 0;
int pointsOnLine = 0;


//Polynomial regression function
vector<double> fitPoly(vector<Point> points, int n)
{
  //Number of points
  int nPoints = points.size();

  //Vectors for all the points' xs and ys
  vector<float> xValues = vector<float>();
  vector<float> yValues = vector<float>();

  //Split the points into two vectors for x and y values
  for(int i = 0; i < nPoints; i++)
  {
    xValues.push_back(points[i].x);
    yValues.push_back(points[i].y);
  }

  //Augmented matrix
  double matrixSystem[n+1][n+2];
  for(int row = 0; row < n+1; row++)
  {
    for(int col = 0; col < n+1; col++)
    {
      matrixSystem[row][col] = 0;
      for(int i = 0; i < nPoints; i++)
        matrixSystem[row][col] += pow(xValues[i], row + col);
    }

    matrixSystem[row][n+1] = 0;
    for(int i = 0; i < nPoints; i++)
      matrixSystem[row][n+1] += pow(xValues[i], row) * yValues[i];

  }

  //Array that holds all the coefs
  double coeffVec[n+2] = {};  // the "= {}" is needed in visual studio, but not in Linux

  //Gauss reduction
  for(int i = 0; i <= n-1; i++)
    for (int k=i+1; k <= n; k++)
    {
      double t=matrixSystem[k][i]/matrixSystem[i][i];

      for (int j=0;j<=n+1;j++)
        matrixSystem[k][j]=matrixSystem[k][j]-t*matrixSystem[i][j];

    }

  //Back-substitution
  for (int i=n;i>=0;i--)
  {
    coeffVec[i]=matrixSystem[i][n+1];
    for (int j=0;j<=n+1;j++)
      if (j!=i)
        coeffVec[i]=coeffVec[i]-matrixSystem[i][j]*coeffVec[j];

    coeffVec[i]=coeffVec[i]/matrixSystem[i][i];
  }

  //Construct the cv vector and return it
  vector<double> result = vector<double>();
  for(int i = 0; i < n+1; i++)
    result.push_back(coeffVec[i]);
  return result;
}

//Returns the point for the equation determined
//by a vector of coefficents, at a certain x location
Point pointAtX(vector<double> coeff, double x)
{
  double y = 0;
  for(int i = 0; i < coeff.size(); i++)
  y += pow(x, i) * coeff[i];
  return Point(x, y);
}

int main(int argc, char *argv[])
{
  if (argc > 1){
		// gets image path
		imagePath = argv[1];
	}
	else {
		// if path is not provided informs user and exits
		printf("Image path not provided, please provide a path\n");
		exit(0);
	}

	//reads the image at image path
	sourceImage = imread(samples::findFile(imagePath), IMREAD_UNCHANGED);
	//if image is read empty then exit
	if(sourceImage.empty()){
		printf("Cannot read file, please check image path %s\n" ,imagePath.c_str());
		exit(0);
	}

  //setting parameter values
  if (imagePath.compare("horizon1.jpg") == 0)
  {
    polynomial = 2;
    pointsOnLine = 1600;
    lowerThreshold = 62;
    thresholdVal = 23;
    minimumLength = 84; 
    maximumGap = 4;
  }
  else if (imagePath.compare("horizon2.png") == 0)
  {
    polynomial = 2;
    pointsOnLine = 1000;
    lowerThreshold = 47;
    thresholdVal = 82;
    minimumLength = 170;
    maximumGap = 8;
  }
  else if (imagePath.compare("horizon3.jpg") == 0)
  {
    polynomial = 1;
    pointsOnLine = 800;
    lowerThreshold = 30;
    thresholdVal = 47;
    minimumLength = 79;
    maximumGap = 24;
  }

  //convert to greyscale
  cvtColor(sourceImage, greyDisplay, COLOR_BGR2GRAY, 0);

  //Canny Edge detection
  namedWindow("Canny Edge Detection", WINDOW_AUTOSIZE);
  blur( greyDisplay, blurDisplay, Size(3,3));
  Canny( blurDisplay, cannyDisplay, lowerThreshold, lowerThreshold*3, 3);
  imshow("Canny Edge Detection", cannyDisplay);
  int k = waitKey(0);
    if(k == 's')
    {
        imwrite("cannyEdgeDetection_"+imagePath, cannyDisplay);
    }

  //Probabiistic Hough Transformation
  namedWindow("Probabilistic Hough Transformation", WINDOW_AUTOSIZE);
  HoughLinesP(cannyDisplay, lines, 1, CV_PI/180, thresholdVal, minimumLength, maximumGap);
  //Draw the detected lines on the image
  sourceImage.copyTo(linesDisplay);
  for (size_t i = 0; i < lines.size(); i++)
  {
      line(linesDisplay, Point(lines[i][0], lines[i][1]), Point(lines[i][2], lines[i][3]), Scalar(0, 0, 255), 3, LINE_AA);
  }
  //Display image
  imshow("Probabilistic Hough Transformation", linesDisplay);
  k = waitKey(0);
    if(k == 's')
    {
        imwrite("houghTransformation_"+imagePath, linesDisplay);
    }


  //Filter short lines using pythagoras
  vector<Vec4i> noShortLines;
  for( size_t i = 0; i < lines.size(); i++ )
  {
    Vec4i currentLine = lines[i];
    double pythagResult = sqrt((currentLine[0] - currentLine[2])*(currentLine[0] - currentLine[2]) + (currentLine[1] - currentLine[3])*(currentLine[1] - currentLine[3]));
    if (pythagResult >= minimumLength) {
        noShortLines.push_back(currentLine);
    }
  }
  //Draw the detected lines on the image
  sourceImage.copyTo(shortFilterDisplay);
  for( size_t i = 0; i < noShortLines.size(); i++ )
  {
    line( shortFilterDisplay, Point(noShortLines[i][0], noShortLines[i][1]),
    Point( noShortLines[i][2], noShortLines[i][3]), Scalar(0,0,255), 3, LINE_AA);
  }
  //Display image
  namedWindow("Short lines filter", WINDOW_AUTOSIZE);
  imshow("Short lines filter", shortFilterDisplay);
  k = waitKey(0);
    if(k == 's')
    {
        imwrite("noShortLines_"+imagePath, shortFilterDisplay);
    }


  // Filter vertical lines by comparing x values
  vector<Vec4i> noVerticalLines;
  for (size_t i = 0; i < noShortLines.size(); i++) {
      Vec4i currentLine = noShortLines[i];
      if (abs(currentLine[0] - currentLine[2]) > abs(currentLine[1] - currentLine[3])) {
          noVerticalLines.push_back(currentLine);
      }
  }
  //Draw the detected lines on the image
  sourceImage.copyTo(horizontalDisplay);
  for( size_t i = 0; i < noVerticalLines.size(); i++ )
  {
    line( horizontalDisplay, Point(noVerticalLines[i][0], noVerticalLines[i][1]),
    Point( noVerticalLines[i][2], noVerticalLines[i][3]), Scalar(0,0,255), 3, LINE_AA);
  }
  //Display image
  namedWindow("Vertical lines filter", WINDOW_AUTOSIZE);
  imshow("Vertical lines filter", horizontalDisplay);
  k = waitKey(0);
    if(k == 's')
    {
        imwrite("noVerticalLines_"+imagePath, horizontalDisplay);
    }

  vector<Point> points;
  for( size_t i = 0; i < noVerticalLines.size(); i++ )
  {
    points.emplace_back(noVerticalLines[i][0], noVerticalLines[i][1]), points.emplace_back(noVerticalLines[i][2], noVerticalLines[i][3]);
  }


  //Draw horizon
  vector<double> coefs;
  coefs = fitPoly(points, polynomial);

  sourceImage.copyTo(horizonDisplay);
  Point p;
  for(int i = 1; i < pointsOnLine; i+=10 )
  {
    p = pointAtX(coefs, i);
    circle(horizonDisplay, p, 3, Scalar(0,0,255));
  }

  namedWindow("Horizon", WINDOW_AUTOSIZE);
  imshow("Horizon", horizonDisplay);
  k = waitKey(0);
    if(k == 's')
    {
        imwrite("horizon_"+imagePath, horizonDisplay);
    }

}
