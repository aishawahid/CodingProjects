#include <stdio.h>
#include <opencv2/core/core.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgcodecs.hpp>
#include "opencv2/imgproc.hpp"
#include <iostream>
using namespace cv;

Mat imageSource, imageGrey, output;
String imagePath;
int thresholdValue = 0;

static void thresholding(int, void*){

	threshold(imageGrey, output, thresholdValue, 255, THRESH_BINARY);
	imshow("Binary Thresholding", output);

}

static void saveOTSU(){

	threshold(imageGrey, output, thresholdValue, 255, THRESH_OTSU);
	String fileName = "OTSU_" + imagePath;
	imwrite(fileName, output);

}

static void reload(){
	
	thresholding(0,0);

	int k = waitKey(0);
	if(k == 's'){
		String fileName = "BINARY_" + std::to_string(thresholdValue) + "_" + imagePath;
		imwrite(fileName, output);
		reload();
	}

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
	imageSource = imread(samples::findFile(imagePath), IMREAD_UNCHANGED);
	//if image is read empty then exit
	if(imageSource.empty()){
		printf("Cannot read file, please check image path %s\n" ,imagePath.c_str());
		exit(0);
	}

	cvtColor(imageSource, imageGrey, COLOR_BGR2GRAY, 0);

	namedWindow("Binary Thresholding", WINDOW_AUTOSIZE);

	saveOTSU();

	createTrackbar("Value: ", "Binary Thresholding", &thresholdValue, 255, thresholding);
	
	thresholding(0,0);

	int k = waitKey(0);
	if(k == 's'){
		String fileName = "BINARY_" + std::to_string(thresholdValue) + "_" + imagePath;
		imwrite(fileName, output);
		reload();
	}
	

} 