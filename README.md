# How to git command line:

## Case 1: files are already at the github.com <br/>
1. `git clone https://github.com/xxxxxxxxxxx.git` <br/>
2.  ... do your changes.....<br/>
3. `git add . `<br/>
4. `git commit -m "My super important commit" `<br/>
5. `git push origin master ` <br/>


## Case 2: brand new project <br/>
1. create new project at the github.com, do **NOT** add any files there<br/>
2. go to the local folder with the files you want to put into the git <br/>
   and run git command line there: <br/>
3. `git init` <br/>
4. `git add . ` <br/>
5. `git commit -m "My super important commit" ` <br/>
6. `git remote add origin https://github.com/xxxxxxxxxxx.git ` <br/>
7. `git push origin master ` <br/>


alternatively, you can use another format to push changes to the github.com: <br/>
`git push https://github.com/bomber100/Unity.git `<br/>


[Source] (https://help.github.com/articles/adding-an-existing-project-to-github-using-the-command-line "help.github.com")