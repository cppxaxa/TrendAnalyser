#include "opencv2/opencv.hpp"

using namespace cv;

extern "C"{

	__declspec(dllexport) int test_1(int, char *argv[])
	{
		VideoCapture cap(0);
		if (!cap.isOpened())
			return -1;
		Mat edges;
		namedWindow("edges", 1);

		Mat frame;
		cap >> frame;
		cvtColor(frame, edges, CV_BGR2GRAY);
		GaussianBlur(edges, edges, Size(7, 7), 1.5, 1.5);
		Canny(edges, edges, 0, 30, 3);
		imshow("edges", edges);

		return 0;
	}

}