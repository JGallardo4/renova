# Official website for Renova, an Edmonton-based home renovations company.

## Technologies used
- ASP.NET Core MVC
- Entity Framework Core

## Deploy
1. Set the following environment variables:
- `RENOVA__DB`
<!-- "User ID=***;Password=***;Host=***;Database=***;Pooling=***;" -->
- `RENOVA__SMTP__HOST`
<!-- "User ID=***;Password=***;Host=***;Database=***;Pooling=***;" -->
- `RENOVA__SMTP__PORT`
<!-- "User ID=***;Password=***;Host=***;Database=***;Pooling=***;" -->
- `RENOVA__SMTP__USERNAME`
<!-- "User ID=***;Password=***;Host=***;Database=***;Pooling=***;" -->
- `RENOVA__SMTP__PWD`
<!-- "User ID=***;Password=***;Host=***;Database=***;Pooling=***;" -->

2. Create Docker image  
`docker build -t renova-image .`

3. Start Docker container  
`docker run -it --rm -p 5089:80 --name renova-container renova-image`