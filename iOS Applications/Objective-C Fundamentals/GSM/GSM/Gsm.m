//
//  Gsm.m
//  GSM

#import "Gsm.h"


@implementation Gsm {
    NSString *_model;
    NSString *_manufacturer;
    CGFloat _price;
    NSString *_owner;
    
}

const CGFloat DefaultPrice = 500;
const NSString *DefaultOwner = @"John Doe";


-(instancetype)initWithModel:(NSString *)model
             andManufacturer:(NSString *)manufacturer {
    self = [super init];
    
    if (self) {
        self.model = model;
        self.manufacturer = manufacturer;
        self.price = DefaultPrice;
        self.owner = DefaultOwner;
        self.battery = [Battery batteryWithModel: @"Li-Ion"];
        self.display = [Display displayWithSize: 4.2 andNuberOfColors:500000];
    }
    
    return self;
}

-(instancetype)initWithModel:(NSString *)model
             andManufacturer:(NSString *)manufacturer
                    andPrice:(CGFloat)price {
    self = [self initWithModel:model andManufacturer:manufacturer];
    
    if (self) {
        self.price = price;
    }
    
    return self;
}

-(instancetype)initWithModel:(NSString *)model
             andManufacturer:(NSString *)manufacturer
                    andPrice:(CGFloat)price
                    andOwner:(NSString *)owner
                  andBattery:(Battery *)battery
                  andDisplay:(Display *)display {
    self = [self initWithModel:model
               andManufacturer:manufacturer
                      andPrice:price];
    
    if (self) {
        self.owner = owner;
        self.battery = battery;
        self.display = display;
    }
    
    return self;
}

+(Gsm *)gsmWithModel:(NSString *)model
            andManufacturer:(NSString *)manufacturer {
    return [[Gsm alloc] initWithModel:model andManufacturer:manufacturer];
}

+(Gsm *)gsmWithModel:(NSString *)model
     andManufacturer:(NSString *)manufacturer
            andPrice:(CGFloat)price {
    return [[Gsm alloc] initWithModel:model andManufacturer:manufacturer andPrice:price];
}

+(Gsm *)gsmWithModel:(NSString *)model
     andManufacturer:(NSString *)manufacturer
            andPrice:(double)price
            andOwner:(NSString *)owner
          andBattery:(Battery *)battery
          andDisplay:(Display *)display {
    return [[Gsm alloc] initWithModel:model
                      andManufacturer:manufacturer
                             andPrice:price
                             andOwner:owner
                           andBattery:battery
                           andDisplay:display];
}

+(Gsm *)iPhone5S {
    return [[Gsm alloc] initWithModel:@"iPhone 5S" andManufacturer:@"Apple" andPrice: 1200];
}

-(NSString *)model {
    return _model;
}

-(void)setModel:(NSString *)model {
    if (!model || [model length] < 3) {
        NSException *ex = [[NSException alloc] initWithName: @"Invalid model" reason: @"Model cannot be null or empty" userInfo:nil];
        [ex raise];
    }
    
    _model = model;
}

-(NSString *)manufacturer {
    return _manufacturer;
}

-(void)setManufacturer:(NSString *)manufacturer {
    if (!manufacturer || [manufacturer length] < 3) {
        NSException *ex = [[NSException alloc] initWithName:@"Invalid manufacturer" reason:@"Manufacturer cannot be null or empty" userInfo: nil];
        [ex raise];
    }
    
    _manufacturer = manufacturer;
}

-(CGFloat)price {
    return _price;
}

-(void)setPrice:(CGFloat)price {
    if (price <= 0) {
        NSException *ex = [[NSException alloc] initWithName:@"Price out of range" reason: @"Price must be bigger than 0" userInfo:nil];
        
        [ex raise];
    }
    
    _price = price;
}

-(NSString *)owner {
    return _owner;
}

-(void)setOwner:(NSString *)owner {
    _owner = owner;
}

-(NSString *)description {
    return [NSString stringWithFormat:@"Model: %@\n Manufacturer: %@\n Price: %.2f\n Owner: %@\n Battery: %@\n Display: %@", self.model, self.manufacturer, self.price, self.owner, self.battery, self.display ];
}

@end
