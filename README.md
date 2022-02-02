# Dockerisation Experiment  
Working in Managed Services, we tend to get projects with different versions of Node, Sql Server, etc  
I want to see how/if I can setup a Docker environment that can run these, so we don't have to fuss around so much to get it running or setup.  

I'm aiming for a `docker compose up` and the whole project "just works".  
I've added some scripts for non-docker users and you can run `bash ./start-dev-environment.sh` and all but the api will start up and give you a shell into the UI so you can run npm commands.  

And that's what I achieved (as a POC)!!  

# Setup  
## Requirements  
These are explained more in [this](https://kaels-kabbage.com/post/dockerising-sql-aspnetcore-react-with-nice-f5-experience) blog post.  

- Clone into the WSL 2 filesystem  
- WSL2 set to Ubuntu distro (probably any major distro, but after installing Docker, it was defaulting to Docker)


After cloning, run `docker compose up` in the root and then hit `http://localhost:3000` and you'll get the standard CRA starting app...BUT it'll say "Learn more with me"!  

Not much I know...but the "me" is coming through the API from the DB, all within docker!  

# Debugging Experience  
Should be able to open DockerTest.sln and F5 in Visual Studio, and do `bash ./start-dev-environment.sh` in the root folder to get the database and React running, which I think is pretty nice.  

## Tests  
Currently I have no test examples because I found out that Visual Studio (Jan 2022) doesn't support running tests in Docker from the Test Explorer.  
The way I'd do it is have a setup just like this one that would run `dotnet test` on the Test project, then just run that as part of the build or whenever you want to look at it.  
I decided that wasn't my favourite experience and got grumpy about it, so I just kinda stopped there.  
`dotnet test` from Docker should work fine, and I think you can have it watch for code changes as well, so you could have it always running the tests; I just don't like it.  