import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Category } from 'src/app/models/category';
import { CategoryService } from 'src/app/services/category.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  form =new FormGroup({
    name:new FormControl(''),
    description:new FormControl(''),
    categoryId:new FormControl('')
  });

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
  createCat(){
    let cat=new Category();
    cat.name=this.form.value.name;
    cat.description=this.form.value.description;
    cat.categoryId=this.form.value.categoryId;

    this.category.createCategories(cat).subscribe(p=>{
      location.reload();
    })
  }

}
