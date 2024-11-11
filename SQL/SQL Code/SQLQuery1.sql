-- rad kommentar

select 
-- projection
	id, 
	name, 
	id+10 as 'idPlus10', 
	'hej' as 'greeting' 
from 
	students
	-- Selection
where 
	id = 1;


select * from students;
