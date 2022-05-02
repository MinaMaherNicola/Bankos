﻿CREATE TABLE Users (
	 id INT IDENTITY PRIMARY KEY NOT NULL,
	 email VARCHAR(255) NOT NULL,
	 password VARCHAR(MAX) NOT NULL,
	 balance MONEY NOT NULL DEFAULT 1000,
	 deleted BIT NOT NULL DEFAULT 0,
	 creationDate DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Transactions (
	id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	senderId INT NOT NULL,
	receiverId INT NOT NULL,
	transactionAmount MONEY NOT NULL,
	creationDate DATETIME NOT NULL DEFAULT GETDATE(),
	CONSTRAINT FK_UserSenderId FOREIGN KEY (senderId) REFERENCES Users (id),
	CONSTRAINT FK_UserReceiverId FOREIGN KEY (receiverId) REFERENCES Users (id)
);