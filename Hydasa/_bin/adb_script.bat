@echo off

set apk_name="%1"
if %apk_name%=="" goto NOT_DEFINED

title Installing %apk_name%

rem allow downgrade apk version, and replace existing installed app
adb install -d -r %apk_name%

echo *
echo **
echo INSTALL DONE
echo **
echo *
title Installing %apk_name%%file_extension% DONE
goto DONE

:NOT_DEFINED
echo apk name was not defined

:DONE
pause