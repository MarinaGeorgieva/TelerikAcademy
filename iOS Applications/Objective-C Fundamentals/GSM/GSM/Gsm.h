//
//  Gsm.h
//  GSM


#import <Foundation/Foundation.h>
#import "Battery.h"
#import "Display.h"

@interface Gsm : NSObject

@property (strong, nonatomic) NSString *model;
@property (strong, nonatomic) NSString *manufacturer;
@property CGFloat price;
@property (strong, nonatomic) NSString *owner;
@property (strong, nonatomic) Battery *battery;
@property (strong, nonatomic) Display *display;


-(instancetype) initWithModel: (NSString *) model
              andManufacturer: (NSString *) manufacturer;

-(instancetype) initWithModel:(NSString *)model
              andManufacturer:(NSString *)manufacturer
                     andPrice:(CGFloat)price;

-(instancetype) initWithModel:(NSString *) model
              andManufacturer:(NSString *) manufacturer
                     andPrice: (CGFloat) price
                     andOwner: (NSString *) owner
                   andBattery: (Battery *) battery
                   andDisplay: (Display *) display;

+(Gsm *) gsmWithModel: (NSString *) model
      andManufacturer: (NSString *) manufacturer;

+(Gsm *) gsmWithModel:(NSString *)model
      andManufacturer:(NSString *)manufacturer
             andPrice:(CGFloat) price;

+(Gsm *) gsmWithModel:(NSString *)model
      andManufacturer:(NSString *)manufacturer
             andPrice: (CGFloat) price
             andOwner: (NSString *) owner
           andBattery: (Battery *) battery
           andDisplay: (Display *) display;

+(Gsm *) iPhone5S;

@end
