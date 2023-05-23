/* statement 1*/ 
SELECT TOP  1 game_name 
from rent 
group by game_name
order by count (*) DESC

/* statement 2 */
SELECT game_name 
from game 
where game_name NOT IN ( select game_name from rent where rent_month=4 )

/* statemnet 3 */
SELECT TOP 1 rent.client_name 
from rent 
left outer join client 
ON rent.client_name = client.client_name
group by rent.client_name 
order by COUNT(*) DESC 

/* statment 4 */
SELECT TOP 1 rent.vendor_name
from rent 
left outer join vendor 
ON rent.vendor_name = vendor.vendorname
group by rent.vendor_name  
order by COUNT(*) DESC 

/* statement 5 */
SELECT vendor.vendorname
from vendor 
where vendorname not in (select vendor_name from rent where rent_month = 4)

/* statement 6 */
Select vendorname 
from vendor 
where vendor.vendor_ID not in (select game.vendor_ID from game where game.year=2021 )