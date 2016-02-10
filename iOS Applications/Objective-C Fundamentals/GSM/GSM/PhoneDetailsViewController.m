#import "PhoneDetailsViewController.h"

@interface PhoneDetailsViewController()


@property (weak, nonatomic) IBOutlet UITextView *detailsTextView;

@end

@implementation PhoneDetailsViewController

-(void)viewDidLoad {
    self.title = @"Phone Details";
    self.detailsTextView.text = [self.gsm description];
}

@end
