import { Component, EventEmitter, Input, Output } from "@angular/core";
import { IStep } from "../../models/step.interface";

@Component({
  selector: 'step-template',
  templateUrl: './step-template.component.html',
  styleUrls: ['./step-template.component.scss']
})
export class StepTemplateComponent {
  @Input() public item: IStep;

  constructor() { }
}
