import platform
import WifiExtractorWindow
import WifiExtractorLinux

#OS Detect
OperatingSystem = platform.system()
print("\033[1;34;40m platform  : \033[1;33;40m ",OperatingSystem )
print("\033[1;32;40m ************************************")
if OperatingSystem == "Windows" :
    print("      I am \033[1;33;40m Windows")
    WifiExtractorWindow.WifiExtratorWindow()
elif OperatingSystem == "Linux" :
    print("      I am \033[1;33;40m Linux")
    WifiExtractorLinux.WifiExtrsctorLinux()
else:
   print("      \033[1;33;40m Can't Detect Platform ")

print("\033[1;32;40m ************************************")
print("\033[1;34;40m"+" Coder By  :"+"\033[1;31;40m"+" h4n24wnyin3")
print("\033[1;37;40m")