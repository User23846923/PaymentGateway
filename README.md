# PaymentGateway

## Run
> cd PaymentGateway
> docker compose up

## Check mapped https ports
> docker ps

CONTAINER ID   IMAGE                COMMAND                  CREATED              STATUS              PORTS                                           NAMES
d271f364bbaa   acquiringbank        "dotnet AcquiringBan…"   About a minute ago   Up About a minute   0.0.0.0:50677->80/tcp, 0.0.0.0:50676->443/tcp   paymentgateway-acquiringbank-1
21670d69f0ac   paymentgateway       "dotnet PaymentGatew…"   About a minute ago   Up About a minute   0.0.0.0:50675->80/tcp, 0.0.0.0:50674->443/tcp   paymentgateway-paymentgateway-1

## Test Acquiring Bank
https://localhost:<port>/swagger/index.html

## Test Payment Gateway
https://localhost:<port>/swagger/index.html
