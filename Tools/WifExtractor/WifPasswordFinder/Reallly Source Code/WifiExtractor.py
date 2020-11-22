import platform
import subprocess
import os

#OS Detect
OperatingSystem = platform.system()
print("platform : "+ OperatingSystem )
print("************************************")
if OperatingSystem == "Windows" :
    print("   I am  Windows")
    data = subprocess.check_output(['netsh','wlan','show','profiles']).decode('utf-8').split('\n')

    wifis = [line.split(':')[1][1:-1] for line in data if  "All User Profile" in line]

    for wifi in wifis:
            results = subprocess.check_output(['netsh','wlan','show','profile',wifi,'key=clear']).decode('utf-8').split('\n')
            results = [line.split(':')[1][1:-1] for line in results if "Key Content" in  line]   
            
            for Pass in results:
                print("Name     : "+ wifi+"\nPassword : "+ Pass)


elif OperatingSystem == "Linux" :
    print("   I am  Linux")
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
             print("Name     :  "+wifi+" \nPassword : " + b)

else:
   print("Can't Detect Platform ")

print("************************************")
print("Coder By : h4n24wnyin3 && 4un97huMy!n7")
