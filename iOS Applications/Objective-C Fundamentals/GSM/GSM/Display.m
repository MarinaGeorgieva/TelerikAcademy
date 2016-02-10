//
//  Display.m
//  GSM

#import "Display.h"

@implementation Display {
    CGFloat _size;
    NSInteger _numberOfColors;
}

-(instancetype)initWithSize:(CGFloat)size
          andNumberOfColors:(NSInteger)numberOfColors {
    self = [super init];
    
    if (self) {
        self.size = size;
        self.numberOfColors = numberOfColors;
    }
    
    return self;
}

+(Display *)displayWithSize:(CGFloat)size
           andNuberOfColors:(NSInteger)numberOfColors {
    return [[Display alloc] initWithSize: size
                       andNumberOfColors: numberOfColors];
}

-(CGFloat)size {
    return _size;
}

-(void)setSize:(CGFloat)size {
    if (size <= 0) {
        NSException *ex = [[NSException alloc] initWithName: @"Size out of range" reason: @"Size must be bigger than 0" userInfo: nil];
        [ex raise];
    }

    _size = size;
}

-(NSInteger)numberOfColors {
    return _numberOfColors;
}

- (void)setNumberOfColors:(NSInteger)numberOfColors {
    if (numberOfColors <= 0) {
        NSException *ex = [[NSException alloc] initWithName: @"Number of colors out of range" reason: @"Number of colors must be bigger than 0" userInfo: nil];
        [ex raise];
    }
    
    _numberOfColors = numberOfColors;
}

- (NSString *)description {
    return [NSString stringWithFormat: @"Size: %.1f, Number of colors: %ld", self.size, (long)self.numberOfColors ];
}

@end
