import os

os.system("echo Choose your .apk file")
i = 0
app_list = []
for file in os.listdir("."):
    if file.endswith(".apk"):
        i+=1
        print(str(i) + ". " + file)
        app_list.append(file)
print("")
choosen = input("app to install: ")
file_name = app_list[int(choosen) - 1]
print("=========================================")
os.system("call adb_script.bat "+file_name)