# Coding4Fun.Net
---

# Presentation
Blabla
---
# Prerequisite
Administrator on windows
laptop (Core i7, 8Go ram)
---
# Step 1 (Environment)
blablab

+++

## Proxy configuration
Public Wifi or 4G :(
---

## Docker 
https://docs.docker.com/toolbox/toolbox_install_windows/
- Do not forget to select "git for windows" during the installation
- Launch docker (You should have a shortcut on your desktop))
- You can do a quick test with : 
````
docker run hello-world
````
---
## Visual Studio Code 
https://code.visualstudio.com/
---

## DotNetCore
https://www.microsoft.com/net/learn/get-started-with-dotnet-tutorial
---

## Github
- Create your accout
- Create a repository named Coding4Fun.Net
---

## Step 2 (Backend)
blablab
+++

## Creation of a database
For this session, we will use a postgre database : 
https://hub.docker.com/_/postgres/
````
docker run --name some-postgres -e POSTGRES_PASSWORD=mysecretpassword -d postgres 
````
---
## PGAdmin
PGAdmin is the admistration site for PostGres 
https://hub.docker.com/r/dpage/pgadmin4/
````
docker run -p 5555:80 -e "PGADMIN_DEFAULT_EMAIL=test@test.com" -e "PGADMIN_DEFAULT_PASSWORD=password" dpage/pgadmin4 
````
Once container has started, you will have access to this url : 
http://your-ip:5555
---
## Docker network 
Create a network and connect your 2 containers
````
docker network create --driver bridge isolated_nw 
docker network connect isolated_nw yyyy
docker network connect isolated_nw xxxx
````
---
## Connection with PGAdmin
Now you can try to connect to your DB in PGAdmin
---
## Usefull docker command
- docker attach
- docker image
- docker ps
- docker inspect
---
## Create your WebApi
create a src folder and launch this command in this folder
````
dotnet new webapi -o Backend
````
Now, build and test
---
## Create your WebApi
````
dotnet new webapi -o Backend
````
Now, build and test (https://localhost:5001/api/Values)
---
## And now as a container
````
dotnet new webapi -o Backend
````
Now, build and test (https://localhost:5001/api/Values)
---




## Annexe
kill all running containers with docker kill $(docker ps -q) 
delete all stopped containers with docker rm $(docker ps -a -q) 
delete all images with docker rmi $(docker images -q) 
 


## Create your WebApi
Install the asp.net authority for development certificate
````
dotnet dev-certs https --trust 
````
---