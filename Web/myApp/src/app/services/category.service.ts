import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from '../models/category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  private baseUrl='https://localhost:7210';

  constructor(private http:HttpClient) { }


  getAllCategories(){
    return this.http.get<Category[]>(this.baseUrl+'/category/get-all');
  }

  createCategories(category:Category){
    return this.http.post(this.baseUrl+'/category/create',category);
  }
}
