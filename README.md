# hello-DevOps

Egyszerű .NET 8 webalkalmazás, amely HTTP-n szöveget ad vissza.

Választott kötelezően választandó feladatrész: 3.4 – Felhő szolgáltatás használata (Render).

## Előfeltételek

- .NET 8 SDK
- Git
- Docker

## Build

1. Klónozd a repót:
   `git clone https://github.com/zolmen/hello-DevOps.git`
2. Lépj be a mappába:
   `cd hello-DevOps`
3. Navigálj a projekt mappájába:
   `cd src/HelloDevOps`
4. Futtasd a buildet:
   `dotnet build`

## Lokális futtatás

1. A projekt mappájában:
   `cd src/HelloDevOps` (ha még nem ott vagy)
2. Futtasd:
   `dotnet run`
3. Böngészőben nyisd meg:
   `http://localhost:8080`
4. Opcionálisan:
   `http://localhost:8080/info`

## Docker

1. Klónozd a repót:
   `git clone https://github.com/zolmen/hello-DevOps.git`
2. Lépj be a mappába:
   `cd hello-DevOps`
3. Építsd fel a Docker image-et:
   `docker build -t hello-devops:v1 .`
4. Futtasd a konténert:
   `docker run -p 8080:8080 hello-devops:v1`
5. Böngészőben nyisd meg:
   `http://localhost:8080`
   vagy
   `http://localhost:8080/info`

## Felhő (Render)

A projekt a Render felhőszolgáltatáson fut.

Publikus URL:
`https://hello-devops-dl5w.onrender.com`

### Deploy lépések

1. Jelentkezz be Renderre GitHub fiókkal.
2. Hozz létre új Web Service-t, és válaszd a `zolmen/hello-DevOps` repót.
3. Branch: `main`.
4. Build: Dockerfile a repo gyökeréből (Language: Docker).
5. Region: például `Frankfurt (EU Central)`.
6. Instance type: `Free`.
7. Port: az alkalmazás a konténeren belül a `8080` porton hallgat.
8. Kattints a „Deploy Web Service” gombra, megvárod, amíg a build és deploy lefut.
9. A publikus URL-en eléred az alkalmazást:
   - `/` → alap üzenet
   - `/info` → info endpoint