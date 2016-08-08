#Repro reproducing a startup directory related bug
This repository reproduces a bug with asp.net core targeting net461 using TestServer. The Server returns 404 on known routes. Switching to netstandard or moving the teststartup file to the main projects fixes the bug.

I would like to use net461 and keep my test related files in a separate project from my main project, so none of those solutions work for me, unfortunately.

##Steps to reproduce the bug
- Run the tests, I would assume both would pass

##Desired behaviour
- Change framework to NETstandard either manually or by checking out the `desired` branch
- Run the tests, both pass