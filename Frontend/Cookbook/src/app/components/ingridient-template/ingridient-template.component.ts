import { Component, EventEmitter, Input, Output } from "@angular/core";
import { IIngridient } from "../../models/ingridient.interface";

@Component({
  selector: 'ingridient-template',
  templateUrl: './ingridient-template.component.html',
  styleUrls: ['./ingridient-template.component.scss']
})
export class IngridientTemplateComponent {
  @Input() public item: IIngridient;

  constructor() { }
}
