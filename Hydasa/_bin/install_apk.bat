@echo off

set apk_name=Hydasa
set file_extension=.apk

title Installing %apk_name%%file_extension%

adb install -r %apk_name%%file_extension%

echo *
echo **
echo INSTALL DONE
echo **
echo *
title Installing %apk_name%%file_extension% DONE
pause