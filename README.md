# hello-DevOps

Egy egyszerű .NET 8 webalkalmazás, amely HTTP-n szöveget ad vissza.

Választott feladatrész: Felhő szolgáltatás használata (Render).

## Előfeltételek

- .NET 8 SDK
- Git
- Docker (Tesztelés publikáció előtt)

## Build

1. Klónozzuk a repót:
   `git clone https://github.com/zolmen/hello-DevOps.git`
2. Lépjünk be a mappába:
   `cd hello-DevOps`
3. Navigáljunk a projekt mappájába:
   `cd src/HelloDevOps`
4. Futtassuk a buildet:
   `dotnet build`

## Lokális futtatás

1. A projekt mappájában:
   `cd src/HelloDevOps` (ha még nem ott vagy)
2. Futtassuk:
   `dotnet run`
3. Böngészőben nyissuk meg:
   `http://localhost:8080`
4. Opcionálisan:
   `http://localhost:8080/info`

## Docker

1. Klónozzuk a repót:
   `git clone https://github.com/zolmen/hello-DevOps.git`
2. Lépjünk be a mappába:
   `cd hello-DevOps`
3. Építsük fel a Docker image-et:
   `docker build -t hello-devops:v1 .`
4. Futtassuk a konténert:
   `docker run -p 8080:8080 hello-devops:v1`
5. Böngészőben nyissuk meg:
   `http://localhost:8080`
   vagy
   `http://localhost:8080/info`

## Felhő (Render)

A projekt a Render felhőszolgáltatáson fut.

Publikus URL:
`https://hello-devops-dl5w.onrender.com`

### Deploy lépések

1. Jelentkezzünk be Renderre GitHub fiókkal.
2. Hozzunk létre új Web Service-t, és válasszuk a `zolmen/hello-DevOps` repót.
3. Branch: `main`.
4. Build: Dockerfile a repo gyökeréből (Language: Docker).
5. Region: például `Frankfurt (EU Central)`.
6. Instance type: `Free`.
7. Port: az alkalmazás a konténeren belül a `8080` porton hallgat.
8. Kattintsunk a „Deploy Web Service” gombra, megvárjuk, amíg a build és deploy lefut.
9. A publikus URL-en elérjük az alkalmazást:
   - `/` → főoldal
   - `/info` → információs portál