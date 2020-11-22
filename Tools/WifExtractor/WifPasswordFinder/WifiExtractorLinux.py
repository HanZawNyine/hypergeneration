import subprocess
import os

def WifiExtrsctorLinux():
    os.chdir(r"/etc/NetworkManager/system-connections") 
#print (a)
    data = os.listdir("/etc/NetworkManager/system-connections")
#print(data)

    for wifi in data:
    #print(wifi)
        results = subprocess.check_output(['sudo','cat',wifi]).split('\n')
        results = [line.split(":") for line in results if "psk=" in  line] 
    #print(results)
        for a in results:
          for b in a:
          #print(b)
             print("Name :  "+wifi+" \nPassword : " + b)