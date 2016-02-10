//
//  ViewController.m
//  GSM

#import "AppDelegate.h"
#import "ViewController.h"
#import "Gsm.h"
#import "PhoneDetailsViewController.h"

@interface ViewController ()

@property (weak, nonatomic) IBOutlet UITableView *tableView;

@property (strong, nonatomic) NSMutableArray *phones;

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    self.title = @"Phones List";
    self.tableView.dataSource = self;
    self.tableView.delegate = self;

}

-(void)viewWillAppear:(BOOL)animated {
    [super viewWillAppear:animated];

    AppDelegate *delegate = [UIApplication sharedApplication].delegate;
    self.phones = delegate.phones;
    [self.tableView reloadData];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

-(NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {
    return self.phones.count;
}


-(UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    static NSString *cellIdentifier = @"PhoneCell";
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:cellIdentifier];
    
    if (!cell) {
        cell = [[UITableViewCell alloc]initWithStyle:UITableViewCellStyleDefault reuseIdentifier:cellIdentifier];
    }
    
    cell.textLabel.text = [self.phones[indexPath.row] model];
    
    return cell;
}

-(void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath {
    Gsm *gsm = self.phones[indexPath.row];
    NSString* storyboardId = @"detailScene";
    PhoneDetailsViewController* vc = [self.storyboard instantiateViewControllerWithIdentifier:storyboardId];
    vc.gsm = gsm;
    [self.navigationController pushViewController:vc animated:YES];
}

@end
