import { Component, OnInit } from '@angular/core';
import { StudentService } from 'src/app/student.service';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit {
  item:any;
  id:any;
  username:any;
  OrderList:any=[];
  constructor(private service:StudentService) { }

  ngOnInit(): void {
    this.data();
    this.sOrderList();
  }
  data(){
    this.item = JSON.parse(localStorage.getItem("Key"));
    console.log(this.item);
    
    this.id=this.item.id;
    this.username=this.item.userName;
    console.log(this.id,this.username);
  }
  sOrderList(){
    var val = {
      StudentId: this.id,
    }
    this.service.orderDetails(val).subscribe(res=>{
      console.log(res);
      this.OrderList=res;
    });
  }

  sReturnBook(data:any){
    var val = {
      StudentId: this.id,
      OrderId:data.orderId,
      BookId:data.bookId
    }
    console.log(data.orderId ,data.bookId );
    
    this.service.returnOrder(val).subscribe(res=>{
      alert("Order Returned successfully");
      this.sOrderList();
    })
  }
}
