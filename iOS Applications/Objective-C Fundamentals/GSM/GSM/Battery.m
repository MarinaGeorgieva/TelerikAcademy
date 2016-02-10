//
//  Battery.m
//  GSM

#import "Battery.h"

@implementation Battery {
    NSString *_model;
    NSInteger _hoursIdle;
    NSInteger _hoursTalk;
    BatteryType _batteryType;
}

const NSInteger DefaultHoursIdle = 20;
const NSInteger DefaultHoursTalk = 10;
const BatteryType DefaultBatteryType = LiIon;

-(instancetype)initWithModel:(NSString *)model {
    self = [super init];
    
    if (self) {
        self.model = model;
        self.hoursIdle = DefaultHoursIdle;
        self.hoursTalk = DefaultHoursTalk;
        self.batteryType = DefaultBatteryType;
    }
    
    return self;
}

-(instancetype)initWithModel:(NSString *)model
                andHoursIdle:(NSInteger)hoursIdle
                andHoursTalk:(NSInteger)hoursTalk
              andBatteryType:(BatteryType)batteryType {
    self = [self initWithModel:model];
    
    if (self) {
        self.hoursIdle = hoursIdle;
        self.hoursTalk = hoursTalk;
        self.batteryType = batteryType;
    }
    
    return self;
}

+(Battery *)batteryWithModel:(NSString *)model {
    return [[Battery alloc] initWithModel:model];
}

+(Battery *)batteryWithModel:(NSString *)model
                andHoursIdle:(NSInteger)hoursIdle
                andHoursTalk:(NSInteger)hoursTalk
              andBatteryType:(BatteryType)batteryType {
    return [[Battery alloc] initWithModel:model
                             andHoursIdle:hoursIdle
                             andHoursTalk:hoursTalk
                           andBatteryType:batteryType];
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

-(NSInteger)hoursIdle {
    return _hoursIdle;
}

-(void)setHoursIdle:(NSInteger)hoursIdle {
    if (hoursIdle <= 0) {
        NSException *ex = [[NSException alloc] initWithName: @"Hours Idle is out of range" reason: @"Hours Idle must be bigger than 0" userInfo: nil];
        [ex raise];
    }
    
    _hoursIdle = hoursIdle;
}

-(NSInteger)hoursTalk {
    return _hoursTalk;
}

-(void)setHoursTalk:(NSInteger)hoursTalk {
    if (hoursTalk <= 0) {
        NSException *ex = [[NSException alloc] initWithName: @"Hours Talk is out of range" reason: @"Hours Talk must be bigger than 0" userInfo: nil];
        [ex raise];
    }
    
    _hoursTalk = hoursTalk;
}

-(NSString *)description {
    return [NSString stringWithFormat: @"Model: %@, Hours idle: %ld, Hours talk: %ld", self.model, (long)self.hoursIdle, (long)self.hoursTalk];
}

@end
