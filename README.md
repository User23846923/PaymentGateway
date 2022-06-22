# PaymentGateway

## Clone it
> git clone https://github.com/User23846923/PaymentGateway.git

> cd PaymentGateway


## Run with Docker
> docker compose up

> docker ps

should show e.g. 
```
CONTAINER ID   IMAGE                COMMAND               CREATED              STATUS              PORTS                  NAMES
30d850da455b   acquiringbank:dev    "tail -f /dev/null"   About a minute ago   Up About a minute   0.0.0.0:5001->80/tcp   AcquiringBank
e2e476ae15e1   paymentgateway:dev   "tail -f /dev/null"   About a minute ago   Up About a minute   0.0.0.0:5000->80/tcp   PaymentGateway
```

## Run on Command Prompt

> cd AcquiringBank

> dotnet run --urls=http://localhost:5001 bin\Debug\net6.0\AcquiringBank.dll

> cd PaymentGateway

> dotnet run --urls=http://loclhost:5000 bin\Debug\net6.0\PaymentGateway.dll


## Test Acquiring Bank
http://localhost:5001/swagger/index.html

## Test Payment Gateway
http://localhost:5000/swagger/index.html
