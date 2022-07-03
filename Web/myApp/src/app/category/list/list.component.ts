import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/models/category';
import { CategoryService } from 'src/app/services/category.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  catlist:Category[];
  constructor(private category:CategoryService) { }

  ngOnInit(): void {
    this.getCatgeoryList();
  }

  getCatgeoryList(){
    this.category.getAllCategories().subscribe(p=>{
      this.catlist=p;
    });
  }

}
