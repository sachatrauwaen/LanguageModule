import { Component, OnInit } from '@angular/core';
import { LanguageModuleService } from '../services/language-module.service';

@Component({
  selector: 'lib-language-module',
  template: ` <p>language-module works!</p> `,
  styles: [],
})
export class LanguageModuleComponent implements OnInit {
  constructor(private service: LanguageModuleService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
