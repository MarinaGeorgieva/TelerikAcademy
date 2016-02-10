//
//  Battery.h
//  GSM


#import <Foundation/Foundation.h>

typedef enum batteryTypes
{
    LiIon,
    NiMH,
    NiCd
} BatteryType;

@interface Battery : NSObject

@property (strong, nonatomic) NSString *model;
@property NSInteger hoursIdle;
@property NSInteger hoursTalk;
@property BatteryType batteryType;

-(instancetype) initWithModel: (NSString *) model;
-(instancetype) initWithModel: (NSString *) model
                 andHoursIdle: (NSInteger) hoursIdle
                 andHoursTalk: (NSInteger) hoursTalk
               andBatteryType: (BatteryType) batteryType;

+(Battery *) batteryWithModel: (NSString *) model;
+(Battery *) batteryWithModel:(NSString *) model
                 andHoursIdle: (NSInteger) hoursIdle
                 andHoursTalk: (NSInteger) hoursTalk
               andBatteryType: (BatteryType) batteryType;

@end
