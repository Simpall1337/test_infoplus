CREATE TABLE Equipment (
    Equipment_ID INT PRIMARY KEY,
    Name VARCHAR(255), --set unique
    Type VARCHAR(100), --add PK table
    Specifications TEXT,
    Price DECIMAL(10, 2)
);

CREATE TABLE Stores (
    Store_ID INT PRIMARY KEY,
    Name VARCHAR(255), 
    Location VARCHAR(255), --set unique
    Contact_Info VARCHAR(255)
);


CREATE TABLE Inventory (
    Inventory_ID INT PRIMARY KEY,
    Equipment_ID INT,
    Store_ID INT,
    Stock INT,
    FOREIGN KEY (Equipment_ID) REFERENCES Equipment(Equipment_ID),
    FOREIGN KEY (Store_ID) REFERENCES Stores(Store_ID)
);
