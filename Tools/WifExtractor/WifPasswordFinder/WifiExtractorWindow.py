import subprocess

def WifiExtratorWindow():
    #Window
        data = subprocess.check_output(['netsh','wlan','show','profiles']).decode('utf-8').split('\n')

        wifis = [line.split(':')[1][1:-1] for line in data if  "All User Profile" in line]

        for wifi in wifis:
            results = subprocess.check_output(['netsh','wlan','show','profile',wifi,'key=clear']).decode('utf-8').split('\n')
            results = [line.split(':')[1][1:-1] for line in results if "Key Content" in  line]   
            
            #NotShowPw = f'Name      :   {wifi}, Password :Cannot Read!'
            try:
                print(f'\033[1;34;40m Name \033[1;31;40m     : {wifi}\n\033[1;34;40m Password  :\033[1;33;40m {results[0]}\n')
                
            except IndexError:
                print("f'Name      :   {wifi}, Password :Cannot Read!")
        



