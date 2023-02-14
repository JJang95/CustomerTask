SELECT * FROM Customer

SELECT * FROM Task

SELECT a.Name FROM Task a
INNER JOIN CustomerTask b ON a.Id = b.TaskId
WHERE b.CustomerId = 1;

UPDATE Customer
SET Name = 'Nancy Pennington'
WHERE Id = 1;

INSERT INTO Customer
VALUES ('Miguel Cruz', '28 Lauren St', 1112329494)

DELETE FROM Customer
WHERE Id = 4;