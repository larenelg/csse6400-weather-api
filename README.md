# CSSE6400 Weather API

1. Download the .NET SDK

2. Download Docker

3. Run Seq on Docker (run this in any terminal)

`docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest`

4. Install the dependencies

`dotnet restore`

5. Run the API (in the root folder of WeatherApi)

`dotnet run`

