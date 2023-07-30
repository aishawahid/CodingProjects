#~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
import cv2

#~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

def dist_thresholding(des1, des2, threshold_value) -> list:

    bf = cv2.BFMatcher()
    matches = bf.knnMatch(des1, des2, k=1500)
    final_list = []
    for match in matches:
        output = []
        for d in match:
            if d.distance < threshold_value:
                output.append(d)
        final_list.append(output)
    return final_list


def nn(des1, des2, threshold_value) -> list:
    bf = cv2.BFMatcher()
    matches = bf.knnMatch(des1, des2, k = 1)
    final_list = []
    if threshold_value == -1:
        for match in matches:
            output = []
            for d in match:
                output.append(d)
            final_list.append(output)
    else:
        for match in matches:
            output = []
            for d in match:
                if d.distance < threshold_value:
                    output.append(d)
            final_list.append(output)
    return final_list


def nndr(des1, des2, threshold_value) -> list:
    bf = cv2.BFMatcher()
    matches = bf.knnMatch(des1, des2, k = 2)
    final_list = []

    for match in matches:
        first_distance = match[0].distance
        second_distance = match[1].distance

        ratio = first_distance / second_distance
        output = []
        if(ratio < threshold_value):
            output.append(match[0])
        final_list.append(output)

    return final_list


#~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
# vim:set et sw=4 ts=4:
