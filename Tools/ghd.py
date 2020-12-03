from googlesearch import search,get_random_user_agent
import re,sys,time,os

r = '\033[031m'
g = '\033[032m'
b = '\033[036m'
y = '\033[033m'
n = '\033[00m'

class ghd(object):
    settings = {
    'count':20,
    'sleep':2,
    'mode':"all",
    'dork': '',
    'target': '',
    'output' : "{dork}_%H%M%d%m.txt"
    }
    helper = {
        'set': 'Set new value to existing value example.',
        'show': 'Show the settings configuration.',
        'run': 'Run the dork',
        'help': 'Show this message'
    }
    filters = []
    regex = {
        'fi': r"(\w*\.[A-Za-z0-9]{,12}(\?|#).*$|\w*\.[A-Za-z0-9]*$|\/\w*(\?|#).*$)",
        'fo': r"(\/\w*\/|\/[^ \.]*$|\/(\?|#).*$)$",
        'all': r"^(http|https)://.*"
    }
    result = []
    def ps(self):
        query = input(f"[{y}GHD{n}]> ")
        if len(query.split(" ")) > 3:
            print(f"[{r}-{n}] Invalid input")
            self.ps()
        while not query:
            self.ps()
        return query.lower()
    def dorker(self, dork):
        if self.settings['target'] != None:
            domain = [self.settings['target']]
        else:
            domain = None
        self.result = search(dork, tld="com", lang='en', num=int(self.settings['count']), stop=int(self.settings['count']), pause=float(self.settings['sleep']), domains=domain,user_agent=get_random_user_agent())
    def filter(self, dork):
        t=0
        fit=0
        for i in self.result:
            if re.search(self.regex[self.settings['mode']], i):
                print(f"[ {g}FOUND{n} ] {b}{i}{n}")
                f = open(time.strftime(self.settings['output'].format(dork=dork)), 'a+')
                f.write(i+'\n')
                t += 1
            else:
                self.filters.append(i)
                fit += 1
        print()
        print(f"[ {g}FINISHED{n} ] Total result {y}{t}{n}")
        print(f"[ {y}FILTER{n} ] Total filter {y}{fit}{n}")
    def start(self):
        try:
            while True:
                query = self.ps()
                command = query.split(" ")
                if command[0] == 'help':
                    for h in self.helper:
                        print(f"{h.upper()}                 {self.helper[h]}")
                elif command[0] == 'set':
                    if command[1] in self.settings:
                        self.settings[command[1]] = command[2]
                        print(f"[{g}+{n}] {command[1]} -> {self.settings[command[1]]}")
                    else:
                        print(f"[{r}-{n}]Settings not found!")
                elif command[0] == 'show':
                    if command[1] == "info": 
                        si = 1
                        for s in self.settings:
                            print(f"{si}) {s} -> {self.settings[s]}")
                            si+=1
                    elif command[1] == 'filters':
                        for fil in self.filters:
                            print(f"[ {y}FILTER{n} ] {fil}")
                    else:
                        print(f"[{r}-{n}] No action found!")
                elif command[0] == 'run':
                    if self.settings['mode'] not in self.regex:
                        print(f"[{r}-{n}] Filter unsupported mode! @ {self.settings['mode']} Reset to default... ", end='')
                        self.settings['mode'] = "all"
                        print(f"{g}OK{n}")
                    print(f"Using the '{self.settings['mode']}' mode @ {self.settings['dork']}")
                    print("Start Dorking... ", end='')
                    print(f"{g}DONE{n}")
                    print()
                    print(f"[{g}+{n}] Checking the file... ", end='')
                    if os.path.isfile(self.settings['dork']):
                        print(f"{g}OK{n}")
                        if input(f"[{b}*{n}] Dork file found! Do u want to process as mass dorker?(Y/n) ").lower() == 'y':
                            f = open(self.settings['dork'], 'r')
                            fd = f.readlines()
                            for dk in fd:
                                if not self.settings['target']:
                                    self.settings['target'] = None
                                tb = "-"*10+f"{g}{dk.strip()}{n}"+"-"*10
                                print(tb)
                                print()
                                self.dorker(dk)
                                self.filter(dk)
                                time.sleep(2)
                                print()

                        else:
                            print(f"[{g}+{n}] Searching as a dork instead of mass dorker.")
                            tb = "-"*10+f"{g}{dk.strip()}{n}"+"-"*10
                            print(tb)
                            if not self.settings['target']:
                                self.settings['target'] = None
                            self.dorker(self.settings['dork'])
                            self.filter(self.settings['dork'])
                    else:
                        print(f"{r}ERROR{n}")
                        print(f"[{g}+{n}] Searching as a dork instead of mass dorker.")
                        if not self.settings['target']:
                            self.settings['target'] = None
                        tb = "-"*10+f"{g}{self.settings['dork']}{n}"+"-"*10
                        print(tb)
                        self.dorker(self.settings['dork'])
                        self.filter(self.settings['dork'])
                elif command[0] == 'exit':
                    break
                else:
                    print(f"[{r}-{n}] Command not found!")
        except KeyboardInterrupt:
            print("[-] User interrupted!")
            sys.exit(0)
        except OSError as e:
            if e:
                print(f"[{r}-{n}]IP Blocked by Google. Try again later!")
                sys.exit(0)
if __name__ == "__main__":
    banner = r"""{y} __                 {r}               _              {n}
{y}/__|_  _  __|_ {g}|_|   .__|_o._  _  {r}| \ _ ._|  _ ._ {n}
{y}\_|| |(_)_> |_ {g}| ||_|| ||_|| |(_| {r}|_/(_)| |<(/_|  {n}
                     {g}          _|                 {n}""".format(y=y,g=g,r=r,n=n)
    print(banner)
    ghd().start()