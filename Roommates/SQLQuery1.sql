SELECT 
roommate.Id AS roommateId, 
Firstname, 
Lastname, 
RentPortion, 
MoveInDate, 
Name, 
MaxOccupancy, 
RoomId 
FROM Roommate 
LEFT JOIN Room ON Room.id = Roommate.RoomId 
WHERE RoomId = 1;