package com.bryan.backend.cartapp.backendcartapp.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RestController;

import com.bryan.backend.cartapp.backendcartapp.services.ProductService;
import com.bryan.backend.cartapp.models.entities.Product;
import java.util.List;
@RestController
public class ProductController {

    @Autowired
    private ProductService service;

    public <Product> List(){}

}
