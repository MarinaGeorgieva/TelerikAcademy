//
//  Display.h
//  GSM

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface Display : NSObject

@property CGFloat size;
@property NSInteger numberOfColors;

-(instancetype) initWithSize: (CGFloat) size
       andNumberOfColors: (NSInteger) numberOfColors;

+(Display *) displayWithSize: (CGFloat) size
               andNuberOfColors: (NSInteger) numberOfColors;

@end
