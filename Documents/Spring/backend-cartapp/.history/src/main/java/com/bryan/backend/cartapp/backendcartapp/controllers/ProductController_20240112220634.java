package com.bryan.backend.cartapp.backendcartapp.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RestController;

import com.bryan.backend.cartapp.backendcartapp.services.ProductService;

@RestController
public class ProductController {

    @Autowired
    private ProductService service;

}
