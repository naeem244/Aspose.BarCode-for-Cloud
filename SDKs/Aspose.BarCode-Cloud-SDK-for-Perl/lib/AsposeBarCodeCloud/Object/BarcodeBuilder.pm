package AsposeBarCodeCloud::Object::BarcodeBuilder;

require 5.6.0;
use strict;
use warnings;
use utf8;
use JSON qw(decode_json);
use Data::Dumper;
use Module::Runtime qw(use_module);
use Log::Any qw($log);
use Date::Parse;
use DateTime;

use base "AsposeBarCodeCloud::Object::BaseObject";

#
#
#
#NOTE: This class is auto generated by the swagger code generator program. Do not edit the class manually.
#

my $swagger_types = {
    'TypeOfBarcode' => 'string',
    'Text' => 'string',
    'Resolution' => 'Resolution',
    'DimensionX' => 'int',
    'DimensionY' => 'int',
    'CodeLocation' => 'string',    
    'GraphicsUnit' => 'string',    
    'AutoSize' => 'boolean',    
    'BarHeight' => 'int',
    'ImageHeight' => 'int',
    'ImageWidth' => 'int',
    'ImageQuality' => 'string',    
    'RotationAngle' => 'int',    
    'BackColor' => 'string',
    'ForeColor' => 'string',
    'CodeTextColor' => 'string',
    'BorderColor' => 'string',
    'EnableChecksum' => 'string',    
    'BorderVisible' => 'boolean',
    'Margins' => 'Margins'
    
};

my $attribute_map = {
    'TypeOfBarcode' => 'TypeOfBarcode',
    'Text' => 'Text',
    'Resolution' => 'Resolution',
    'DimensionX' => 'DimensionX',
    'DimensionY' => 'DimensionY',
    'CodeLocation' => 'CodeLocation',    
    'GraphicsUnit' => 'GraphicsUnit',    
    'AutoSize' => 'AutoSize',    
    'BarHeight' => 'BarHeight',
    'ImageHeight' => 'ImageHeight',
    'ImageWidth' => 'ImageWidth',
    'ImageQuality' => 'ImageQuality',    
    'RotationAngle' => 'RotationAngle',    
    'BackColor' => 'BackColor',
    'ForeColor' => 'ForeColor',
    'CodeTextColor' => 'CodeTextColor',
    'BorderColor' => 'BorderColor',
    'EnableChecksum' => 'EnableChecksum',    
    'BorderVisible' => 'BorderVisible',
    'Margins' => 'Margins'
};

# new object
sub new { 
    my ($class, %args) = @_; 
    my $self = { 
   'TypeOfBarcode' => $args{'TypeOfBarcode'},
    'Text' => $args{'Text'},
    'Resolution' => $args{'Resolution'},
    'DimensionX' => $args{'DimensionX'},
    'DimensionY' => $args{'DimensionY'},
    'CodeLocation' => $args{'CodeLocation'},    
    'GraphicsUnit' => $args{'GraphicsUnit'},    
    'AutoSize' => $args{'AutoSize'},    
    'BarHeight' => $args{'BarHeight'},
    'ImageHeight' => $args{'ImageHeight'},
    'ImageWidth' => $args{'ImageWidth'},
    'ImageQuality' => $args{'ImageQuality'},    
    'RotationAngle' => $args{'RotationAngle'},    
    'BackColor' => $args{'BackColor'},
    'ForeColor' => $args{'ForeColor'},
    'CodeTextColor' => $args{'CodeTextColor'},
    'BorderColor' => $args{'BorderColor'},
    'EnableChecksum' => $args{'EnableChecksum'},    
    'BorderVisible' => $args{'BorderVisible'},    
    'Margins' => $args{'Margins'}
    }; 

    return bless $self, $class; 
}  

# get swagger type of the attribute
sub get_swagger_types {
    return $swagger_types;
}

# get attribute mappping
sub get_attribute_map {
    return $attribute_map;
}

1;
