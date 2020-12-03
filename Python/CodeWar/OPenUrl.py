import webbrowser

a = input("Enter Your File (*.txt) :")
with open(a) as f:
    lines = f.readlines()
    for b in lines:
        print(b) 
        webbrowser.open(b, new=2)