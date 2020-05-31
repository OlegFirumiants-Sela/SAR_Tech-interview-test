SELECT * FROM Widgets WHERE Active = 0

SELECT * FROM Widgets WHERE Widget LIKE 'Demo%'

SELECT * FROM Widgets WHERE Widget LIKE '%Registration%'

SELECT Lang FROM Widgets WHERE SiteName = 'https://www.fxlider.com'

SELECT SiteName, COUNT(SELECT Lang 
					   FROM Widgets 
					   GROUP BY SiteName) AS LangCount
INTO TempTable
FROM Widgets
