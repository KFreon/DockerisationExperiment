# Dockerisation Experiment  
Working in Managed Services, we tend to get projects with different versions of Node, Sql Server, etc  
I want to see how/if I can setup a Docker environment that can run these, so we don't have to fuss around so much to get it running or setup.  

I'm aiming for a `docker compose up` and the whole project "just works".  

And that's what I achieved!!  

# Setup  
## Requirements  
These are explained more in [this]() blog post.  

- Clone into the WSL 2 filesystem  
- WSL2 set to Ubuntu distro (probably any major distro, but after installing Docker, it was defaulting to Docker)


After cloning, should just be able to do `docker compose up` and then hit `localhost:3000` and you'll get the standard CRA starting app...BUT it'll say "Learn more with me"!  

Not much I know...but the "me" is coming through the API from the DB, all within docker :) :) :)  

# Debugging Experience  
Should be able to open DockerTest.sln and F5 in Visual Studio, and do `npm run docker` in the UI folder to get the database and React running, which I think is pretty nice.  