# Assignment Project 2 
## The Aim of the Project
Example JSON Model = {"Id" :1,"Name" : "Deny","Lastname" : "Sellen","DateOfBirth" : "01-01-1989","Email":"deny@gmail.com","PhoneNumber" :"555443366","Salary" : 4450}
- Define a Staff class representing the given above JSON model.
- Add a Controller and apply all HTTP methods using this class. 
- Perform all operations on a static list that acts like a database.
## Validation Rules
- A name can contain a minimum of 2 and maximum of 50 characters.
- A Last name can contain a minimum of 2 and maximum of 50 characters.
- A name and last name cannot contain any special characters or numbers.
- Date of Birth has to be between 11.11.1945 and 10.10.2002
- An email cannot contain any special characters or numbers other than "." and "@".
- A phone number has to be validated considering country code.
- Salary has to be between 2000 and 9000.
## Project Structure and Explanations
![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/1.png)
<p> Figure 1. Project Layers </p>

## Business
It is the layer where business codes are written and validations are performed.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/b2.png)
<p> Figure 2. Business Folder Structure </p>

## DataAccess 
It is the layer in which the operations required to access the data are performed.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/data3.png)
<p> Figure 3. DataAccess Folder Structure </p>

## Entities 
It is the layer where classes are generated corresponding to the database tables.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/entity4.png)
<p> Figure 4. Entities Folder Structure </p>

## Web API
This allows the program to communicate with different applications such as IOS and Angular etc.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/webap%C4%B15.png)
<p> Figure 5. Web API Folder Structure </p>

## Results
## Swagger Display
![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/swagger.png)
<p align="center"> Figure 6. Swagger Display </p>

## GetAll Method
- This method is used to obtain all the items in the list.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/getall.png)
<p align="center"> Figure 7. GetAll Method </p>

## GetById Method
- This method is used to bring the element according to the id of the element.
- If the element with a given ID is not in the list, the program will give the relevant message.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/getbyid.png)
<p align="center"> Figure 8. GetById Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/getbyinvalidid.png)
<p align="center"> Figure 9. GetById Method with Invalid ID </p>

## Add Method
- This method is used to add the instance with the parameters taken from body to the list.
- If a staff already on the list is tried to be added, the program transmits the required message. 

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/addvaildid.png)
<p align="center"> Figure 10. Add Method with Existing ID </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/addoperation.png)
<p align="center"> Figure 11. Add Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/addafter.png)
<p align="center"> Figure 12. After Add Method </p>


## Update Method
- This method is used to update the instance according to the parameters taken from body to the list.
- If a staff instance not on the list is tried to be updated, the program transmits the required message.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/updateinvalidid.png)
<p align="center"> Figure 13. Update Method with Invalid ID </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/updateoperation.png)
<p align="center"> Figure 14. Update Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/updateafter.png)
<p align="center"> Figure 15. After Update Method </p>

## Delete Method
- This method is used to delete the instance according to the parameters taken from body to the list.
- If a staff instance not on the list is tried to be deleted, the program transmits the required message.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/deleteoperation.png)
<p align="center"> Figure 16. Delete Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/deleteafter.png)
<p align="center"> Figure 17. After Delete Method </p>

##Validation Results

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/blob/master/images/validationfail.png)
<p align="center"> Figure 18. Inappropriate Staff Instance </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-2-berkdemirciogluu/commit/52eaba6c5ffab96f83368ca312a743f74ca8a0f6)
<p align="center"> Figure 19. Appropriate Staff Instance </p>







