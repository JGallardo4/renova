# Official website for Renova, an Edmonton-based home renovations company.

## Technologies used
- ASP.NET Core MVC
- Entity Framework Core

## Deploy
1. Set the following environment variables:
- `RENOVA__DB`
- `RENOVA__ADMIN_EMAIL`
- `RENOVA__ADMIN_PWD`

2. Create Docker image  
`docker build -t renova-image .`

3. Start Docker container  
`docker run -e RENOVA__DB -e RENOVA__ADMIN_PWD -e RENOVA__ADMIN_EMAIL -it --rm -p 5089:80 --name renova-container renova-image`