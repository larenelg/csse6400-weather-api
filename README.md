# CSSE6400 Weather API

1. Download and install the .NET 6.0 SDK

2. Download and install Docker

3. Run Seq on Docker (run this in any terminal)

`docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest`

4. Install the dependencies (in the root folder of this project)

`dotnet restore`

5. Run the API (in the root folder of this project)

`dotnet run`

6. Check that it's working in Postman (in Postman, go Import > Raw Text > Paste the curl below)

`curl --location --request GET 'http://localhost:5248/weatherforecast'`

7. Add the POST endpoint as well (in Postman, go Import > Raw Text > Paste the curl below)

```
curl --location --request POST 'http://localhost:5248/weatherforecast' \
--header 'Content-Type: application/json' \
--data-raw '"Spicy"'
```