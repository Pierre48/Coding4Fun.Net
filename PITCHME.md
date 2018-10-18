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
docker run hello-world" 
````
---

## Network setting about docker
- use bridge mode in vbox network setting
- retrieve the ip with the command "ifconfig"
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

## Step 3 (Backend)
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
???
---
## Create your WebApi
---








## Create your WebApi
Install the asp.net authority for development certificate
````
dotnet dev-certs https --trust 
````
---