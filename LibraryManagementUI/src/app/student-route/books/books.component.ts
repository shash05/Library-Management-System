import { Component, Input, OnInit } from '@angular/core';
import { StudentService } from 'src/app/student.service';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css'],
})
export class BooksComponent implements OnInit {
  constructor(private service: StudentService) {}
  BookList:any=[];
  item: any;
  id: any;
  username: any;
   book:any;
   BookId:number;

  ngOnInit(): void {
    this.data();
    this.sBookList();
  }

  data() {
    this.item = JSON.parse(localStorage.getItem('Key'));
    console.log(this.item);

    this.id = this.item.id;
    this.username = this.item.userName;
  }

  sBookList(){
    var val = {
      StudentId: this.id,
    }
    this.service.books(val).subscribe(res=>{
      console.log(res);
      this.BookList=res;
    });
  }

  sPlaceOrder(BookId: any){
      var val={
        StudentId: this.id,
        BookId: BookId,
      }
      
      this.service.placeOrder(val).subscribe(res=>{
      alert("order placed SuccessFully");
      this.sBookList();
      });
  }
}