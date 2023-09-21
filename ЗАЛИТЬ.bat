git init
git add .
set CURRENT_DATE=%date%
set CURRENT_TIME=%time%
git commit -m "Time: %CURRENT_TIME%, date: %CURRENT_DATE%"
git push origin main