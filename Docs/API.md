## Auth

### Register

´´´js
POST {{host}}/auth/register
´´´

#### Register request

´´´json
{
    "firstName": "Laura",
    "lastName": "Bte",
    "email": "laura@gmail.com",
    "password": "1234"
}
´´´

#### Register response

´´´js
200 OK
´´´
´´´json
{
    "id": "62e31cb6-1915-422e-b6cd-e5c1b1ed0e15",
    "firstName": "Laura",
    "lastName": "Bte",
    "email": "laura@gmail.com",
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXV...sgY6kfxPhNirU4kRg"
}
´´´

### Login

´´´js
POST {{host}}/auth/login
´´´

#### Login request

´´´json
{
    "email": "laura@gmail.com",
    "password": "1234"
}
´´´

#### Login response

´´´js
200 OK
´´´
´´´json
{
    "id": "62e31cb6-1915-422e-b6cd-e5c1b1ed0e15",
    "firstName": "Laura",
    "lastName": "Bte",
    "email": "laura@gmail.com",
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXV...sgY6kfxPhNirU4kRg"
}
´´´
