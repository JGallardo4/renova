# Official website for Renova, an Edmonton-based home renovations company.

## Technologies used
- ASP.NET Core MVC
- Entity Framework Core

## Deploy
1. Set the following environment variables:
- `RENOVA__DB`
<!-- "User ID=***;Password=***;Host=***;Database=***;Pooling=***;" -->
- `RENOVA__SENDGRID_API`
- `RENOVA__TO_ADDRESS`
- `RENOVA__FROM_ADDRESS`

2. Create Docker image  
`docker build -t renova-image .`

3. Start Docker container  
`docker run -it --rm -p 5089:80 --name renova-container renova-image`