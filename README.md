# CatFact API

Prosta aplikacja ASP.NET Core Web API, która pobiera fakty o kotach z zewnętrznego endpointu, zapisuje je lokalnie do pliku `.txt` i udostępnia przez API.

---

## Uruchomienie przez Docker Compose

1. Upewnij się, że masz zainstalowanego [Dockera](https://docs.docker.com/get-docker/).

2. W katalogu projektu uruchom:

bash:
docker-compose up --build

3. Aplikacja dostępna pod 
http://localhost:5001

4. Endpointy API
http://localhost:5001/swagger/index.html - testowanie api za pomocą Swaggera
http://localhost:5001/CatFact/log - pobierz i zapisz nowy fakt o kotach
