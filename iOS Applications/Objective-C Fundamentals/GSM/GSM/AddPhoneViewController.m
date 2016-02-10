#import "AddPhoneViewController.h"
#import "AppDelegate.h"
#import "Gsm.h"
#import "Battery.h"
#import "Display.h"

@interface AddPhoneViewController()
@property (weak, nonatomic) IBOutlet UITextField *modelTextField;
@property (weak, nonatomic) IBOutlet UITextField *manufacturerTextField;
@property (weak, nonatomic) IBOutlet UITextField *priceTextField;
@property (weak, nonatomic) IBOutlet UITextField *ownerTextField;
@property (weak, nonatomic) IBOutlet UITextField *batteryModelTextField;
@property (weak, nonatomic) IBOutlet UITextField *displaySizeTextField;
@property (weak, nonatomic) IBOutlet UITextField *displayColorsTextField;

@end

@implementation AddPhoneViewController


-(void)viewDidLoad {
    self.title = @"Add Phone";
}


- (IBAction)saveButton:(id)sender {
    if ([self.modelTextField.text isEqualToString:@""] ||
        [self.manufacturerTextField.text isEqualToString:@""]) {
        UIAlertController *alertController = [UIAlertController  alertControllerWithTitle:@"Model and manufacturer fields are required!"  message:nil  preferredStyle:UIAlertControllerStyleAlert];
        [alertController addAction:[UIAlertAction actionWithTitle:@"OK" style:UIAlertActionStyleDefault handler:^(UIAlertAction *action) {
            [self dismissViewControllerAnimated:YES completion:nil];
        }]];
        [self presentViewController:alertController animated:YES completion:nil];
        return;
    }
    
    Battery *battery = [[Battery alloc] initWithModel:self.batteryModelTextField.text];
    Display *display = [[Display alloc] initWithSize:[self.displaySizeTextField.text floatValue]
                                   andNumberOfColors:[self.displayColorsTextField.text integerValue]];
    
    Gsm *gsm = [[Gsm alloc] initWithModel: self.modelTextField.text
                          andManufacturer:self.manufacturerTextField.text
                                 andPrice:[self.priceTextField.text floatValue]
                                 andOwner:self.ownerTextField.text
                               andBattery:battery
                               andDisplay:display];

    AppDelegate* delegate = [UIApplication sharedApplication].delegate;
    
    [delegate.phones addObject:gsm];
    
    [self.navigationController popViewControllerAnimated:YES];
}
@end
