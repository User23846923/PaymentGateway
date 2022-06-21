# PaymentGateway

## Run
> cd PaymentGateway

> docker compose up

## Check mapped http ports
> docker ps
```
CONTAINER ID   IMAGE                COMMAND               CREATED              STATUS              PORTS                  NAMES
30d850da455b   acquiringbank:dev    "tail -f /dev/null"   About a minute ago   Up About a minute   0.0.0.0:5001->80/tcp   AcquiringBank
e2e476ae15e1   paymentgateway:dev   "tail -f /dev/null"   About a minute ago   Up About a minute   0.0.0.0:5000->80/tcp   PaymentGateway
```

## Test Acquiring Bank
http://localhost:5001/swagger/index.html

## Test Payment Gateway
http://localhost:5000/swagger/index.html
