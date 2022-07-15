# SubscriptionApp
Permite que las empresas hagan suscripciones y permite consultarlas

### Creación de tablas SQL Server ###

```
CREATE TABLE Empresas (
    id int IDENTITY(1,1) NOT NULL,
    name varchar(50) NOT NULL,
    quantity int,
    PRIMARY KEY (id)
);
```

```
CREATE TABLE SubsTransaction (
	transid int IDENTITY(1,1) NOT NULL,
	quantity int NOT NULL,
	price int NOT NULL,
	datatrans date NOT NULL,
	empresa int NOT NULL FOREIGN KEY REFERENCES Empresas(id),
	PRIMARY KEY (transid)
);
```
